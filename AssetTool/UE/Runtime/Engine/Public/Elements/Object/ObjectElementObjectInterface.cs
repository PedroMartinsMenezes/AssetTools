namespace AssetTool
{
    [JsonAsset("ObjectElementObjectInterface")]
    public class UObjectElementObjectInterface : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}