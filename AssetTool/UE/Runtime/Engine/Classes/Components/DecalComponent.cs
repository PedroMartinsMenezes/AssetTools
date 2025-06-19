namespace AssetTool
{
    [JsonAsset("DecalComponent")]
    public class UDecalComponent : USceneComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}