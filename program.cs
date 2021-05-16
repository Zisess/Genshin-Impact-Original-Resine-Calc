
void stuff...{

            DateTime StartedTime = DateTime.Now;
            int val = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(
                "Estimated Hours : " + (((160 - val) * 8) / 60).ToString() + "\r\n"+
                "Estimated Minutes : " + (((160 - val) * 8)).ToString() + "\r\n" +
                "Estimated Seconds : " + (((160 - val) * 8) * 60).ToString()
                );

            while (..)
            {
                Thread.Sleep(480000); // 8 minutes
                TimeSpan timespent = (DateTime.Now - StartedTime);
                string str = (((int)timespent.TotalSeconds) / 480).ToString();
                string h = (((int)timespent.TotalSeconds / 60) / 60).ToString();
                string m = ((int)timespent.TotalSeconds / 60).ToString();
                string s = ((int)timespent.TotalSeconds).ToString();
                Console.Clear();
                Console.Title = h + ":" + m + ":" + s;
                Console.WriteLine("Replenished O.Resin Value: &" + str);
            }
            
            }
