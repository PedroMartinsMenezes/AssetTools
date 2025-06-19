namespace AssetTool
{
    [JsonAsset("Scene")]
    public class UScene : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}