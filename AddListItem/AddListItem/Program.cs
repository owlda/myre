using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SharePoint;

namespace AddItemList
{
        class Program
        {
            static void Main(string[] args)
            {
                using (SPSite site = new SPSite("http://sharepointsrv/sites/portal"))
                {
                    using (SPWeb web = site.OpenWeb())
                    {
                        SPList list = web.GetList("/Lists/MemosLst/");
                        SPListItemCollection items = list.Items;

                        SPListItem item = items.Add();
                        item[SPBuiltInFieldId.Title] = "Новая служебная записка";
                        item[SPBuiltInFieldId.Body] = "Создана для исправления ошибочного удаления элемента.";
                        item[SPBuiltInFieldId.Expires] = DateTime.Now.AddHours(1);
                        item[SPBuiltInFieldId.ID] = 10608;
                        item.Update();
                        
                        Guid id = item.UniqueId;
                        
                    Console.WriteLine(items[id].Title);
                    }
                }
                Console.ReadLine();
            }
        }
    }
