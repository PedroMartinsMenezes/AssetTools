namespace AssetTool
{
    [JsonAsset("ObjectReferencer")]
    public class UObjectReferencer : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}