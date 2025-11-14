namespace AssetTool
{
    [JsonAsset("PawnNoiseEmitterComponent")]
    public class UPawnNoiseEmitterComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}