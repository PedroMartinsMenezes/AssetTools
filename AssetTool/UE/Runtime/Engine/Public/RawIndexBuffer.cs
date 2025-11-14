using System.ComponentModel;

namespace AssetTool
{
    [Description("Can be FRawStaticIndexBuffer16or32 or FRawStaticIndexBuffer16or32")]
    public class FRawStaticIndexBuffer16or32Interface : FIndexBuffer, ITransferable
    {
        ///TResourceArray<INDEX_TYPE, INDEXBUFFER_ALIGNMENT> Indices;
        public ITransferable Move(Transfer transfer)
        {
            ///Indices.BulkSerialize(Ar);
            throw new NotImplementedException();
        }
    }
}
