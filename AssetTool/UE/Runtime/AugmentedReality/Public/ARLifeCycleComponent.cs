namespace AssetTool
{
    [JsonAsset("ARLifeCycleComponent")]
    public class UARLifeCycleComponent : USceneComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}