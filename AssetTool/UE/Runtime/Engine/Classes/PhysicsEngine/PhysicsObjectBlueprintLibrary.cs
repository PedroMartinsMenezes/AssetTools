namespace AssetTool
{
    [JsonAsset("PhysicsObjectBlueprintLibrary")]
    public class UPhysicsObjectBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}