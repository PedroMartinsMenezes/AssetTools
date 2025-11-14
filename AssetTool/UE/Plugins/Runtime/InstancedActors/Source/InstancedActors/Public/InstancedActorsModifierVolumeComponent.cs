namespace AssetTool
{
    [JsonAsset("InstancedActorsModifierVolumeComponent")]
    public class UInstancedActorsModifierVolumeComponent : UPrimitiveComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RemoveInstancesModifierVolumeComponent")]
    public class URemoveInstancesModifierVolumeComponent : UInstancedActorsModifierVolumeComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}