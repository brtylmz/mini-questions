{

            float countOfBanana = 3000;
            float yol = 1000;
            float capacity = 1000;
            float seferSayisi = 0;
            float durakSayisi = (countOfBanana / capacity) - 1;
            double result = 31;
            List<DurakSayisiModel> durakSayisiModel = new List<DurakSayisiModel>();

            for (int i = 1; i <= durakSayisi; i++)
            {
                durakSayisiModel.Add(new DurakSayisiModel
                {
                    durakSayi = i,
                    muzSayisi = countOfBanana - i * capacity
                });
            }

            for (int i = 0; i < durakSayisi; i++)
            {

                if (countOfBanana > capacity)
                {
                    seferSayisi = ((countOfBanana / capacity) * 2 - 1);

                    if (i > 0)
                    {

                        durakSayisiModel[i].mesafe = ((countOfBanana - durakSayisiModel[i].muzSayisi) / seferSayisi) + durakSayisiModel[i - 1].mesafe;
                        if (durakSayisiModel[i].mesafe > yol)
                        {
                            durakSayisiModel[i].mesafe = yol;
                        }
                        countOfBanana = durakSayisiModel[i].muzSayisi;
                    }
                    else
                    {
                        durakSayisiModel[i].mesafe = Convert.ToDouble((countOfBanana - durakSayisiModel[i].muzSayisi) / seferSayisi);
                        countOfBanana = durakSayisiModel[i].muzSayisi;
                    }

                }
                result = countOfBanana - (yol - durakSayisiModel[i].mesafe);

            }
            foreach (var item in durakSayisiModel)
            {
                Console.WriteLine("Durak:" + item.durakSayi + "\n" + "Konum:" + item.mesafe + "\n" + "Muz Sayısı:" + item.muzSayisi + "\n\n");

            }
            Console.WriteLine("Kalan Muz sayısı:" + result);
            Console.ReadLine();
