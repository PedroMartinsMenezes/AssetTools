namespace AssetTool
{
    [JsonAsset("PhysicsObjectBlueprintLibrary")]
    public class UPhysicsObjectBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}