namespace AssetTool
{
    [JsonAsset("PawnNoiseEmitterComponent")]
    public class UPawnNoiseEmitterComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}