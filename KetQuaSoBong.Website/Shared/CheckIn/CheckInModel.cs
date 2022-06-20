using MongoDB.Bson.Serialization.Attributes;

namespace KetQuaSoBong.Website.Shared.CheckIn;

public class CheckInModel
{
    [BsonElement("_id")]
    public string UserName { get; set; }
    public string Passwd { get; set; }
    public string TimeStart { get; set; }
    public string TimeEnd { get; set; }
}