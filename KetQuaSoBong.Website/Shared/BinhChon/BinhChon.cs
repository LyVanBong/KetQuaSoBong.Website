using MongoDB.Bson.Serialization.Attributes;

namespace KetQuaSoBong.Website.Shared.BinhChon;

public class BinhChon
{
    [BsonElement("_id")]
    public string Number { get; set; }
    public int SoLuongBinhChon { get; set; }
}