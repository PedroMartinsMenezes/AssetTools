namespace AssetTool
{
    [JsonAsset("PhysicsFieldComponent")]
    public class UPhysicsFieldComponent : USceneComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PhysicsFieldStatics")]
    public class UPhysicsFieldStatics : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}