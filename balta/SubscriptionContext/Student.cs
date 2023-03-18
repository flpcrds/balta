using balta.SharedContext;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balta.SubscriptionContext
{
    public  class Student : Base
    {
        public Student()
        {
            Subscriptions = new List<Subscription>();
        }
        public string Name { get; set; }

        public string Email { get; set; }

        public User user { get; set; }

        public IList<Subscription> Subscriptions { get; set; }

        public void CreateSubscription(Subscription subscription){
            if (IsPremium)
            {
                AddNotification(new NotificationContext.Notification("Premium", "O aluno já tem uma assinatura ativa"));
                return;
            }

            Subscription.Add(subscription);
        }

        public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);
    }
}
