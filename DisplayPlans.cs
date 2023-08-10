using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace saf_demo
{
    public class DisplayPlans
    {
        List<DataPlanDTO> dataPlans = new List<DataPlanDTO>();
        public DisplayPlans()
        {
            dataPlans = new DataService().GetDataPlans();
        }
        public void showPlansCategories()
        {

            //THE BELOW  COMMENTED CODE IS PREFERRED !!
            // foreach(var item in dataPlans.Select(x=>x.Plans).Distinct()){
            // Console.WriteLine(item);
            // }


            Console.WriteLine((int)Plans.Daily + "." + Plans.Daily);
            Console.WriteLine((int)Plans.Weekly + "." + Plans.Weekly);
            Console.WriteLine((int)Plans.Monthly + "." + Plans.Monthly);

            Console.WriteLine("Select a Category");
            var SelectedCategpry = Console.ReadLine();
            var SelectCategoyInput = Validation(SelectedCategpry);
            if (SelectCategoyInput != 0)
            {
                // Console.WriteLine(SelectCategoyInput);

                filterBasedOnInput(SelectCategoyInput);
            }
            else
            {
                Console.WriteLine("Invalid Input");
                //  showPlansCategories();
            }

        }
        public int Validation(string Category)
        {
            if (string.IsNullOrWhiteSpace(Category))
            {
                Console.WriteLine("Invalid Choice Please pitch a plan");
                showPlansCategories();
                //exit
            }
            else
            {
                //string provided is a 'number '  ....  get a string that we want to either 1,2,3

                bool canConverted = int.TryParse(Category, out int converted);
                if (canConverted && converted > 0 && converted < 4)
                {
                    return converted;
                }
                return 0;

            }
            showPlansCategories();
            return 0;
        }

        //filter
        public void filterBasedOnInput(int Category)
        {
            var filtered = dataPlans.FindAll(x => (int)x.Plans == Category);
            foreach (var item in filtered)
            {
                Console.WriteLine($"{item.PlanDescription} @ {item.Price}");
            }
        }

    }
}