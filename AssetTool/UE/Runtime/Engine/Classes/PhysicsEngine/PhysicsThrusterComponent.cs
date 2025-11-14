namespace AssetTool
{
    [JsonAsset("PhysicsThrusterComponent")]
    public class UPhysicsThrusterComponent : USceneComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}