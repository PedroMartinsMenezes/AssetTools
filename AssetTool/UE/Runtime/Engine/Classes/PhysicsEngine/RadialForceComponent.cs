namespace AssetTool
{
    [JsonAsset("RadialForceComponent")]
    public class URadialForceComponent : USceneComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}