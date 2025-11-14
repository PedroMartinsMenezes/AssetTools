namespace AssetTool
{
    [JsonAsset("AvaSceneSettings")]
    public class UAvaSceneSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}