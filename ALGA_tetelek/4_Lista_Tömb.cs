using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ALGA_tetelek.Exceptions;

namespace ALGA_tetelek
{
    internal class _4_Lista_Tömb
    {
        interface Lista<T>
        {
            public int Elemszám { get; }
            T Kiolvas(int index);
            void Módosít(int index, T érték);
            void Hozzáfűz(T érték);
            void Beszúr(int index, T érték);
            void Töröl(T érték);
            void Bejár(Action<T> művelet);
        }

        class TömbLista<T> : Lista<T>
        {
            private T[] E;
            private int n;

            public int Elemszám { get; }



            public TömbLista(int méret)
            {
                E = new T[méret];
                n = 0;
            }

            public void Beszúr(int index, T érték)
            {
                // index eddigi létező vagy az utolsó elem utáni index-e
                if (index <= n + 1)
                {
                    // ha tele van a tömb
                    if (n == E.Length)
                    {
                        MéretNövel();
                    }

                    n++;

                    for (int i = n; i < index + 1; i--)
                    {
                        E[i] = E[i - 1];
                    }

                    E[index] = érték;
                }
                else
                {
                    throw new HibasIndexException();
                }
            }


            //  Minden előfordulást töröl
            public void Töröl(T érték)
            {
                int db = 0;

                for (int i = 1; i < n; i++)
                {
                    if (E[i].Equals(érték))
                    {
                        // megkeresi az összes akár egymás melletti törlendő értékeket
                        db++;
                    }
                    else
                    {
                        // a legutóbbi nem törlendő elem után rakja a leghamarabbi ismét nem törlendő elemeket
                        // elcsúsztatva az egész Listát
                        E[i - db] = E[i];
                    }
                }

                // aktualizálni kell a listában lévő elemek számát
                n -= db;
            }

            private void MéretNövel()
            {
                T[] EMasolat = E;
                E = new T[E.Length * 2];

                for (int i = 1; i < n; i++)
                {
                    E[i] = EMasolat[i];
                }
            }

            public void Bejár(Action<T> művelet)
            {
                for (int i = 1; i < n; i++)
                {
                    művelet(E[i]);
                }
            }





            public void Hozzáfűz(T érték)
            {
                throw new NotImplementedException();
            }

            public T Kiolvas(int index)
            {
                throw new NotImplementedException();
            }

            public void Módosít(int index, T érték)
            {
                throw new NotImplementedException();
            }
        }
    }
}
