using GridTest.Server.Models;

namespace GridTest.Server.Repositories
{
    public class Repository
    {
        public GridFormElement GetGrid(int rowCount)
        {
            return new GridFormElement()
            {
                Id = "mainGrid",
                Name = "Grid1",
                IsStaticGrid = true,
                IsWideScreenGrid = true,
                FrozenWidth = 62,
                Height = 36,
                FrozenColumns = GetFrozenColumns(),
                ScrollableColumns = GetScrollableColumns(),
                Rows = GetRows(rowCount),
            };
        }

        private List<HeaderGridFormElement> GetFrozenColumns()
        {
            return new List<HeaderGridFormElement>
            {
                new HeaderGridFormElement
                {
                    Id = "1010000",
                    Index = 0,
                    Title = "No",
                    IsFrozen = true
                },
                new HeaderGridFormElement
                {
                    Id = "1020000",
                    Index = 1,
                    Title = "Title",
                    IsFrozen = true
                }
            };
        }

        private List<HeaderGridFormElement> GetScrollableColumns()
        {
            return new List<HeaderGridFormElement>
            {
                new HeaderGridFormElement
                {
                    Id = "0010000",
                    Index = 2,
                    Title = "Test_1",
                    IsFrozen = false
                },
                new HeaderGridFormElement
                {
                    Id = "0020000",
                    Index = 3,
                    Title = "Test_2",
                    IsFrozen = false
                },

                new HeaderGridFormElement
                {
                    Id = "0030000",
                    Index = 4,
                    Title = "Test_3",
                    IsFrozen = false
                }
            };
        }

        private List<RowGridFormElement> GetRows(int rowCount)
        {
            var rows = new RowGridFormElement[rowCount];
            for (int i = 0; i< rowCount; ++i)
            {
                rows[i] = GetRow(i);
            }

            return rows.ToList();
        }

        private RowGridFormElement GetRow(int rowIndex)
        {
            return new RowGridFormElement
            {
                Cells = GetCells(rowIndex)
            };
        }

        private List<FieldFormElement> GetCells(int rowIndex) 
        {
            var rowIndexString = rowIndex.ToString();

            return new List<FieldFormElement>
            {
                new FieldFormElement
                {
                    Id = "200" + rowIndexString,
                    Index = rowIndex + 200000,
                    Value = rowIndexString,
                    Readonly = true
                },
                new FieldFormElement
                {
                    Id = "300"+ rowIndexString,
                    Index = rowIndex + 300000,
                    Value = "Title: " + rowIndexString,
                    Readonly = true
                },
                new FieldFormElement
                {
                    Id = "400" + rowIndexString,
                    Index = rowIndex + 400000,
                    Value = "Test_1_" + rowIndexString,
                    Readonly = true
                },
                new FieldFormElement
                {
                    Id = "500"+ rowIndexString,
                    Index = rowIndex+500000,
                    Value = "Test_2_" + rowIndexString,
                    Readonly = true
                },
                new FieldFormElement
                {
                    Id = "600"+ rowIndexString,
                    Index = rowIndex+600000,
                    Value = "Test_3_" + rowIndexString,
                    Readonly = true
                }
            };
        }
    }
}
