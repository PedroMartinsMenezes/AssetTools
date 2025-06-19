namespace AssetTool
{
    [JsonAsset("AvaSceneState")]
    public class UAvaSceneState : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}