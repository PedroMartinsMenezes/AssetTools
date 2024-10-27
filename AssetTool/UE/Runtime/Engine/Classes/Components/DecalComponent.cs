namespace AssetTool
{
    [JsonAsset("DecalComponent")]
    public class UDecalComponent : USceneComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}