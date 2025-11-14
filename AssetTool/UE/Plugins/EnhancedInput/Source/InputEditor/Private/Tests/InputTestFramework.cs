namespace AssetTool
{
    [JsonAsset("InputBindingTarget")]
    public class UInputBindingTarget : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MockedEnhancedInputSubsystem")]
    public class UMockedEnhancedInputSubsystem : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MockInputUserSettings")]
    public class UMockInputUserSettings : UEnhancedInputUserSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ControllablePlayer")]
    public class UControllablePlayer : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestMappableKeysAction")]
    public class UTestMappableKeysAction : UInputAction
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}