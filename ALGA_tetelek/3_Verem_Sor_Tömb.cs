using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ALGA_tetelek.Exceptions;

namespace ALGA_tetelek
{
    internal class _3_Verem_Sor_Tömb
    {
        interface IVerem<T>
        {
            public bool Üres { get; }
            void Verembe(T érték);
            T Veremből();
            T Felső();
        }

        class TömbVerem<T> : IVerem<T>
        {
            private T[] E;
            private int n;

            public TömbVerem(int méret)
            {
                E = new T[méret];
            }

            public bool Üres { get; }

            public T Felső()
            {
                if (n > 0)
                {
                    return E[n];
                }
                else
                {
                    throw new NincsElemException();
                }
            }

            public void Verembe(T érték)
            {
                if (n < E.Length)
                {
                    n++;
                    E[n] = érték;
                }
                else
                {
                    throw new NincsHelyException();
                }
            }

            public T Veremből()
            {
                if (n > 0)
                {
                    T érték = E[n];
                    n--;
                    return érték;
                }
                else
                {
                    throw new NincsElemException();
                }
            }
        }

        interface Sor<T>
        {
            public bool Üres { get; }

            void Sorba(T érték);
            T Sorból();
            T Első();
        }

        class TömbSor<T> : Sor<T>
        {
            private T[] E;
            private int e;
            private int u;
            private int n;

            public TömbSor(int méret)
            {
                E = new T[méret];
            }

            public bool Üres { get; }

            public T Első()
            {
                if (n > 0)
                {
                    return E[(e % E.Length) + 1];
                }
                else
                {
                    throw new NincsElemException();
                }
            }

            public void Sorba(T érték)
            {
                if (n < E.Length)
                {
                    n++;
                    u = (u % E.Length) + 1;
                    E[u] = érték;
                }
                else
                {
                    throw new NincsHelyException();
                }
            }

            public T Sorból()
            {
                if (n > 0)
                {
                    n--;
                    e = (e % E.Length) + 1;
                    T érték = E[e];
                    return érték;
                }
                else
                {
                    throw new NincsElemException();
                }
            }
        }
    }
}
