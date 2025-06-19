namespace AssetTool
{
    [JsonAsset("ObjectElementDetailsInterface")]
    public class UObjectElementDetailsInterface : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}