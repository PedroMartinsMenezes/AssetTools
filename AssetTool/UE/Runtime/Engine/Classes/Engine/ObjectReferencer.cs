namespace AssetTool
{
    [JsonAsset("ObjectReferencer")]
    public class UObjectReferencer : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}