//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HuizenmarktApp.Observer
//{
//    public class Subject
//    {
//        //ArrayList arrObs = new ArrayList();
//        private delegate void NotifyHandler(string _color);
//        private event NotifyHandler NotifyEvent;

//        public Subject()
//        {
//            this.NotifyEvent += new NotifyHandler(Notify);
//        }

//        public void UpdateClient(string _color)
//        {
//            OnNotify(_color);
//        }

//        private void OnNotify(string _color)
//        {
//            if (NotifyEvent != null)
//            {
//                NotifyEvent(_color);
//            }
//        }

//        private void Notify(string _color)
//        {
//            for (int i = 0; i < arrObs.Count; i++)
//            {
//                Observer obs = (Observer)arrObs[i];
//                obs.Update(_color);
//            }
//        }

//        public void RegisterClient(Observer obs)
//        {
//            arrObs.Add(obs);
//        }
//    }
//}
