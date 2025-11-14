namespace AssetTool
{
    [JsonAsset("PhysicsObjectBlueprintLibrary")]
    public class UPhysicsObjectBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}