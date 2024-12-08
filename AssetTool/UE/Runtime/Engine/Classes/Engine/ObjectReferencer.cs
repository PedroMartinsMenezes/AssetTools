namespace AssetTool
{
    [JsonAsset("ObjectReferencer")]
    public class UObjectReferencer : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}