using MongoDB.Bson.Serialization.Attributes;

namespace KetQuaSoBong.Website.Shared.Kqxs;

public class KqxsMbModel : KqxsModel
{
    [BsonElement("_id")]
    public string NgayQuay { get; set; }
}