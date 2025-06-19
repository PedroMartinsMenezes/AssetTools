namespace AssetTool
{
    [JsonAsset("AvaSceneSettings")]
    public class UAvaSceneSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}