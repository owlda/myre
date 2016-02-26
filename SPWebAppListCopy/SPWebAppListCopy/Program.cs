using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint;
using System.IO;


namespace CopyListInSameSiteCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Копирование списка для Sharepoint 2010 в другое расположение.");
            Console.WriteLine("Введите URL-адрес приложения источника:");
            String @sourceSite = Console.ReadLine();
            
            Console.WriteLine("Введите название списка:");
            String @sourceListName = Console.ReadLine();
            
            Console.WriteLine("Введите URL-адрес приложения назначения:");
            String @destinationSite = Console.ReadLine();
            
            Console.WriteLine("Введите название списка назначения:");
            String @destinationListName = Console.ReadLine();
            
            Console.WriteLine("Введите описание списка назначения:");
            String @destinationListDescription = Console.ReadLine();
            try
            {
                using (SPSite site = new SPSite(@sourceSite))
                {
                    using (SPWeb web = site.OpenWeb())
                    {
                        SPList sourceList = web.Lists[@sourceListName];
                        String templateName = sourceList.Title;
                        String templateFileName = sourceList.Title;
                        sourceList.SaveAsTemplate(templateFileName, templateName, sourceList.Description, true);
                        SPListTemplate listTemplate = site.GetCustomListTemplates(web)[templateName];

                        String destinationWeb = @destinationSite.Remove(0, site.Url.Length + 1);
                        using (SPWeb destWeb = site.OpenWeb(destinationWeb))
                        {
                            destWeb.Lists.Add(@destinationListName, @destinationListDescription, listTemplate);
                            destWeb.Update();


                        }
                        SPList listTemplates = site.RootWeb.Lists["Шаблоны списков"];
                        SPListItemCollection listTemplateItems = listTemplates.Items;
                        foreach (SPListItem listTemplateItem in listTemplateItems)
                        {

                            if (listTemplate.Name.Equals(listTemplateItem["Title"]))
                            {
                                listTemplateItem.Delete();
                                listTemplates.Update();
                                break;
                            }
                        }
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Копирование списка завершено.");
        }
    }
}