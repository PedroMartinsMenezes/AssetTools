namespace AssetTool
{
    [JsonAsset("DecalComponent")]
    public class UDecalComponent : USceneComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}