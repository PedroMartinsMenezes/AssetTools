namespace AssetTool
{
    [JsonAsset("BrainComponent")]
    public class UBrainComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}