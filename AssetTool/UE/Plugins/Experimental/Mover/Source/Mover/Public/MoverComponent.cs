namespace AssetTool
{
    [JsonAsset("MoverComponent", "KinematicMoverComponent")]
    public class UMoverComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}