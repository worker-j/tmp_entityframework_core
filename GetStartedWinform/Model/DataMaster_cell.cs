using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace GetStartedWinform.Model
{
    public enum LineIdEnum
    {
        Line1 = 1,
        Line2 = 2
    }
    public enum RowNoEnum
    {
        Row1 = 1,
        Row2 = 2
    }
    public enum BayNoEnum
    {
        Bay1 = 1,
        Bay2 = 2,
        Bay3 = 3,
        Bay4 = 4,
        Bay5 = 5,
        Bay6 = 6,
        Bay7 = 7,
        Bay8 = 8,
        Bay9 = 9,
        Bay10 = 10,
        Bay11 = 11,
        Bay12 = 12,
        Bay13 = 13,
        Bay14 = 14,
        Bay15 = 15,
        Bay16 = 16,
        Bay17 = 17
    }
    public enum LevelNoEnum
    {
        Level1 = 1,
        Level2 = 2,
        Level3 = 3,
        Level4 = 4,
        Level5 = 5,
        Level6 = 6,
        Level7 = 7
    }
    public class DataMaster_cell
    {
        //[Key]
        //[Required]
        //public LineIdEnum LineId { get; set; }
        //[Required]
        //public RowNoEnum RowNo { get; set; }
        //[Required]
        //public BayNoEnum BayNo { get; set; }
        //[Required]
        //public LevelNoEnum LevelNo { get; set; }
        public int DataMaster_cellId { get; set; }
        public string?  CellMode { get; set; }
        public string? CellType { get; set; }
        public string? CellLock { get; set; }
        public string? Delivery { get; set; }
        public string? ItemCode { get; set; }
        public string? itemCell { get; set; }
        public int LotCount { get; set; } = 0;

    }
}
