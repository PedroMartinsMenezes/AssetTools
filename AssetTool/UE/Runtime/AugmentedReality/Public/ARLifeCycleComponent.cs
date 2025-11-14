namespace AssetTool
{
    [JsonAsset("ARLifeCycleComponent")]
    public class UARLifeCycleComponent : USceneComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}