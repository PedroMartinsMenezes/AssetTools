namespace AssetTool
{
    [JsonAsset("CEEffectorComponent")]
    public class UCEEffectorComponent : USceneComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}