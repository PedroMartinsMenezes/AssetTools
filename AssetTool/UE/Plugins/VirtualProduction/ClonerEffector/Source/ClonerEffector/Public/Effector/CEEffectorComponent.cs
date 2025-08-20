namespace AssetTool
{
    [JsonAsset("CEEffectorComponent")]
    public class UCEEffectorComponent : USceneComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}