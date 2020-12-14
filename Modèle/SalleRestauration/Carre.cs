using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modèle.SalleRestauration
{
    public class Carre
    {
        List<Table> tables;
        public int id;

        public Carre(int rank)
        {
            this.id = rank;
            tables = new List<Table>();
            if (rank == 1)
            {
                for (int i = 2; i<=10; i+=2)
                {
                    switch (i)
                    {
                        case 2:
                            for (int nb = 0; nb < 5; nb++)
                            {
                                tables.Add(new Table(i));
                            }
                            break;

                        case 4:
                            for (int nb = 0; nb < 5; nb++)
                            {
                                tables.Add(new Table(i));
                            }
                            break;

                        case 6:
                            for (int nb = 0; nb < 3; nb++)
                            {
                                tables.Add(new Table(i));
                            }
                            break;

                        case 8:
                            for (int nb = 0; nb < 2; nb++)
                            {
                                tables.Add(new Table(i));
                            }
                            break;

                        case 10:
                            tables.Add(new Table(i));
                            break;


                        default:
                            break;
                    }
                }
            }
            else
            {
                for (int i = 2; i <= 10; i += 2)
                {
                    switch (i)
                    {
                        case 2:
                            for (int nb = 0; nb < 5; nb++)
                            {
                                tables.Add(new Table(i));
                            }
                            break;

                        case 4:
                            for (int nb = 0; nb < 5; nb++)
                            {
                                tables.Add(new Table(i));
                            }
                            break;

                        case 6:
                            for (int nb = 0; nb < 2; nb++)
                            {
                                tables.Add(new Table(i));
                            }
                            break;

                        case 8:
                            for (int nb = 0; nb < 3; nb++)
                            {
                                tables.Add(new Table(i));
                            }
                            break;

                        case 10:
                            tables.Add(new Table(i));
                            break;


                        default:
                            break;
                    }
                }
            }
            
        }
    }
}
