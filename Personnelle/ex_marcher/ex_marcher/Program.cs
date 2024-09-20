
using Aspose.Cells;
using System.Net.Http.Headers;

namespace ex_marcher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Workbook wb = new Workbook("C:\\Users\\pu41ecx\\Documents\\Github\\323-Programmation_fonctionnelle\\exos\\marché\\Place du marché.xlsx");

            Worksheet worksheet = wb.Worksheets[1];

            int rows = worksheet.Cells.MaxDataRow;
            int cols = worksheet.Cells.MaxDataColumn;

            var data = new List<stand>();

            int count = 0;
            int BovayStand = 0;
            //Dictionary<string, int> stand = new Dictionary<string, int>();


         

            for (int x= 1; x < rows; x++)
            {
                for(int y = 0; y < cols; y++)
                {
                    int place = Convert.ToInt32(worksheet.Cells[x, y].Value.ToString());
                    string seller = worksheet.Cells[x, y].Value.ToString();
                    int product = Convert.ToInt32(worksheet.Cells[x, y].Value.ToString());
                    int quantity = Convert.ToInt32(worksheet.Cells[x, y].Value.ToString());
                    string unit = worksheet.Cells[x, y].Value.ToString();
                    float price = Convert.ToSingle(worksheet.Cells[x, y].Value.ToString());
                    data.Add(new stand(place
                        , seller
                        ,product
                        ,quantity
                        , unit
                        , place
                        
                        ));
                }
                
            }

            

            Console.WriteLine(data);

            //for (x = 0; x < rows; x++)
            //{
            //    for (y = 0; y < cols; y++)
                

            //        if (worksheet.Cells[x, y].Value.ToString() == "Pêches")
            //        {
            //            count++;
            //        }

            //        if (worksheet.Cells[x, y].Value.ToString() == "Pastèques")
            //        {

            //            int pastekQuant = Convert.ToInt32(worksheet.Cells[x, 3].Value.ToString());

            //            stand.Add(worksheet.Cells[x, 1].Value.ToString(), pastekQuant);
            //        }

            //        if (worksheet.Cells[x, 1].Value.ToString() == "Bovay")
            //        {
            //            BovayStand = Convert.ToInt32(worksheet.Cells[x, 0].Value.ToString());
            //        }

            //    }
            //}

            //int max = stand.Values.Max();
            //string producteur = "";
            //foreach (var a in stand)
            //{
            //    if(a.Value==max)
            //    {
            //        producteur = a.Key;
            //    }
            //}

            //Console.WriteLine($"Il y a {count} vendeur de pêche");
            //Console.WriteLine($"C'est {producteur} qui à le plus de pastèques. ({BovayStand} , {stand.Values.Max()} pièces)");
        
    
        }
    }
}
