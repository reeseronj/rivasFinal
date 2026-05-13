using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagementSystemRivas.models
{
    public class Subscription
    {
        public int subscription_id;
        public string plan="";
        public int duration;
        public int price;

    }
}
