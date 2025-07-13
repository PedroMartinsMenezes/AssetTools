namespace AssetTool
{
    [JsonAsset("PPMChainGraphExecutorComponent")]
    public class UPPMChainGraphExecutorComponent : USceneComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}