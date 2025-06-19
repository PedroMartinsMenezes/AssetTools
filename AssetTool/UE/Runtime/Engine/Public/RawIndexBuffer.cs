using System.ComponentModel;

namespace AssetTool
{
    [Description("Can be FRawStaticIndexBuffer16or32 or FRawStaticIndexBuffer16or32")]
    public class FRawStaticIndexBuffer16or32Interface : FIndexBuffer, ITransferible
    {
        ///TResourceArray<INDEX_TYPE, INDEXBUFFER_ALIGNMENT> Indices;
        public ITransferible Move(Transfer transfer)
        {
            ///Indices.BulkSerialize(Ar);
            throw new NotImplementedException();
        }
    }
}
