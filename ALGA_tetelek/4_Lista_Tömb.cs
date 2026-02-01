using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            public TömbLista(int méret)
            {
                E = new T[méret];
            }

            public int Elemszám { get; }

            public void Bejár(Action<T> művelet)
            {
                throw new NotImplementedException();
            }

            public void Beszúr(int index, T érték)
            {
                throw new NotImplementedException();
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

            public void Töröl(T érték)
            {
                throw new NotImplementedException();
            }
        }
    }
}
