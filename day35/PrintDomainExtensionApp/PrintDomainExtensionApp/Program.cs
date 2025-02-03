namespace PrintDomainExtensionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] domainsNames = { "test.org", "sample.com", "stage.edu","yahoo.co.in"};
            string[] extensions = ExtractDomainExtensions(domainsNames);

            foreach (var extension in extensions)
            {
                Console.WriteLine(extension);
            }
        }

        //Using split method
        static string[] ExtractDomainExtensions(string[] domainsNames)
        {
            string[] extensions = new string[domainsNames.Length];
            Console.WriteLine("Length of array is:" + domainsNames.Length);

            for (int i = 0; i < domainsNames.Length; i++)
            {
                // Split the domain by '.' and take everything after the first part
                string[] parts = domainsNames[i].Split('.');
                if (parts.Length > 1)
                {
                    // Join all parts except the first one back together with '.' in between
                    extensions[i] = string.Join(".", parts, 1, parts.Length - 1);
                }
                else
                {
                    extensions[i] = string.Empty; // or handle it as per your requirement
                }
            }

            return extensions;
        }


            /*
            static string[] ExtractDomainExtensions(string[] domains)
            {
                string[] extensions = new string[domains.Length];

                for (int i = 0; i < domains.Length; i++)
                {
                    int firstDotIndex = -1;
                    for (int j = 0; j < domains[i].Length; j++)
                    {
                        if (domains[i][j] == '.')
                        {
                            firstDotIndex = j;
                            break;
                        }
                    }

                    if (firstDotIndex != -1)
                    {
                        extensions[i] = domains[i].Substring(firstDotIndex + 1);
                    }
                    else
                    {
                        extensions[i] = string.Empty; // or handle it as per your requirement
                    }
                }

                return extensions;
            }
            */


            /*
            //If '.' is found, it extracts the substring starting from the character after '.' to the end of the string using Substring.
            static string[] ExtractDomainExtensions(string[] domains)
            {
                string[] extensions = new string[domains.Length];

                for (int i = 0; i < domains.Length; i++)
                {
                    int lastDotIndex = domains[i].LastIndexOf('.');
                    if (lastDotIndex != -1)
                    {
                        extensions[i] = domains[i].Substring(lastDotIndex + 1);
                    }
                    else
                    {
                        extensions[i] = string.Empty; // or handle it as per your requirement
                    }
                }

                return extensions;
            }
            */
        }
}
