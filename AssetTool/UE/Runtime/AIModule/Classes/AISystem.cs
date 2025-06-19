namespace AssetTool
{
    [JsonAsset("AISystem")]
    public class UAISystem : UAISystemBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}