namespace AssetTool
{
    [JsonAsset("MassSmartObjectInitializerBase")]
    public class UMassSmartObjectInitializerBase : UMassObserverProcessor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassSmartObjectDeinitializerBase")]
    public class UMassSmartObjectDeinitializerBase : UMassObserverProcessor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassActiveSmartObjectInitializer")]
    public class UMassActiveSmartObjectInitializer : UMassSmartObjectInitializerBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassActiveSmartObjectDeinitializer")]
    public class UMassActiveSmartObjectDeinitializer : UMassSmartObjectDeinitializerBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassActorInstanceHandleInitializer")]
    public class UMassActorInstanceHandleInitializer : UMassSmartObjectInitializerBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassActorInstanceHandleDeinitializer")]
    public class UMassActorInstanceHandleDeinitializer : UMassSmartObjectDeinitializerBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassActiveSmartObjectSignalProcessor")]
    public class UMassActiveSmartObjectSignalProcessor : UMassSignalProcessorBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}