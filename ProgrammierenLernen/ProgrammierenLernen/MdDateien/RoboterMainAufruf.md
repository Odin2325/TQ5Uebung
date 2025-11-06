            Person person1 = new Person("Max Mustermann", "Berlin 99", false);
            Person person2 = new Person("Rosie Rosalie", "Berlin 98", true);
            Person person3 = new Person("The Grinch", "Berlin 97", true);

            PolizeiRoboter polizeiRoboter = new PolizeiRoboter("Berlin Strasse");
            polizeiRoboter.KriminellenHinzufuegen(new Person("Rosie Rosalie", "Berlin 98", true));
            polizeiRoboter.KriminellenHinzufuegen(new Person("Bobby Brown", "Berlin 91", true));


            //|person1|person2|person3|polizeiRoboter

            /*
             * Speicher1: Max Mustermann, Berlin 99, false
             * Speicher2: "Rosie Rosalie", "Berlin 98", true
             * Speicher3: "The Grinch", "Berlin 97", true
             * Speicher4: polizeiRoboter.KriminellenListe
             *      unterSpeicher1:"Rosie Rosalie", "Berlin 98", true
             *      unterSpeicher2:"Bobby Brown", "Berlin 91", true
             * 
             */

            Console.WriteLine("Vergleich Person 1:");
            polizeiRoboter.PersonVergleichen(person1);
            Console.WriteLine("Vergleich Person 2:");
            polizeiRoboter.PersonVergleichen(person2);
            Console.WriteLine("Vergleich Person 3:");
            polizeiRoboter.PersonVergleichen(person3);