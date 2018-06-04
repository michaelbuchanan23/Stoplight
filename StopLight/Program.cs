using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stoplight {
	class Program {
		//USE OF THE ENUM CODE BEGINS HERE --  Greg said this is easier to understand
		enum TrafficLight {
			Red=1,
			Green,
			Yellow
		};

		void DisplayTrafficLight(TrafficLight color) {
			switch (color) {
				case TrafficLight.Red:
					Console.WriteLine("Red");
					break;
				case TrafficLight.Green:
					Console.WriteLine("Green");
					break;
				case TrafficLight.Yellow:
					Console.WriteLine("Yellow");
					break;
			}
		}

		void run() {
			for (int idx = 0; idx < 3; idx++) {
				int coloridx = 1; //note that int = 0 is equal to enum type = 1
				TrafficLight color = (TrafficLight) coloridx; //cast coloridx to TrafficLight -- we are changing value of coloridx when we do this
				DisplayTrafficLight(color);
				color = (TrafficLight)(++coloridx);
				DisplayTrafficLight(color);
				color = (TrafficLight)(++coloridx);
				DisplayTrafficLight(color);
			}
		}
		//USE OF THE ENUM CODE ENDS HERE

		/* this was how we did the traffic light before we used the enum type
		void DisplayTrafficLight(int color) {
			switch(color) {
				case 1:
					Console.WriteLine("Red");
					break;
				case 2:
					Console.WriteLine("Green");
					break;
				case 3:
					Console.WriteLine("Yellow");
					break;
			}
		}

		void run() {
			for (int idx = 0; idx < 3; idx++) {
				int color = 1; //simulates the color is supposed to be red
				DisplayTrafficLight(color);
				DisplayTrafficLight(++color);
				DisplayTrafficLight(++color);
			}
		}
		*/

		static void Main(string[] args) {
			(new Program()).run(); //calling the run function above this
		}
	}
}
