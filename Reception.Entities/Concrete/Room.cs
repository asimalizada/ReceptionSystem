using Reception.Entities.Abstract;

namespace Reception.Entities.Concrete;
public class Room : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }    
    public int RowNumber {  get; set; }
    public int Floor {  get; set; }

    public string Number
    {
        get
        {
            return Floor + string.Empty + RowNumber;
        }
    }
}
