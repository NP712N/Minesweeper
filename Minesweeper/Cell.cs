using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    /*
* HO TEN: NGUYEN PHAT NGHI
* LOP: TH1602
* MA SO SV: 16DH110117
* CA: 2
* THU: Tu
* PM: 08
*/
    class Cell
    {
        public bool IsMine { get; set; }
        public bool IsFlag { get; set; }
        public byte MinesAround { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Cell(int x , int y )
        {
            IsMine  = IsFlag = false;
            MinesAround=0;
            X = x;
            Y = y;
        }
        public Cell(bool IsMine,bool IsOpened, bool IsFlag,bool IsMarked,byte MinesAround)
        {
            this.IsMine = IsMine;
            this.IsFlag = IsFlag;
            this.MinesAround = MinesAround;
        }       
    }
}
