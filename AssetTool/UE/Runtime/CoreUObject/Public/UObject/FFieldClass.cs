namespace AssetTool
{
    public class FFieldClass
    {
        private static Dictionary<string, Func<FField>> NameToFieldClassMap { get; set; } = [];

        static FFieldClass()
        {
            NameToFieldClassMap[FArrayProperty.TYPE_NAME] = () => new FArrayProperty();
            NameToFieldClassMap[FBoolProperty.TYPE_NAME] = () => new FBoolProperty();
            NameToFieldClassMap[FByteProperty.TYPE_NAME] = () => new FByteProperty();
            NameToFieldClassMap[FClassProperty.TYPE_NAME] = () => new FClassProperty();
            NameToFieldClassMap[FClassPtrProperty.TYPE_NAME] = () => new FClassPtrProperty();
            NameToFieldClassMap[FDelegateProperty.TYPE_NAME] = () => new FDelegateProperty();
            NameToFieldClassMap[FDoubleProperty.TYPE_NAME] = () => new FDoubleProperty();
            NameToFieldClassMap[FEnumProperty.TYPE_NAME] = () => new FEnumProperty();
            NameToFieldClassMap[FFieldPathProperty.TYPE_NAME] = () => new FFieldPathProperty();
            NameToFieldClassMap[FFloatProperty.TYPE_NAME] = () => new FFloatProperty();
            NameToFieldClassMap[FInt16Property.TYPE_NAME] = () => new FInt16Property();
            NameToFieldClassMap[FInt64Property.TYPE_NAME] = () => new FInt64Property();
            NameToFieldClassMap[FInt8Property.TYPE_NAME] = () => new FInt8Property();
            NameToFieldClassMap[FInterfaceProperty.TYPE_NAME] = () => new FInterfaceProperty();
            NameToFieldClassMap[FIntProperty.TYPE_NAME] = () => new FIntProperty();
            NameToFieldClassMap[FLazyObjectProperty.TYPE_NAME] = () => new FLazyObjectProperty();
            NameToFieldClassMap[FMapProperty.TYPE_NAME] = () => new FMapProperty();
            NameToFieldClassMap[FMulticastDelegateProperty.TYPE_NAME] = () => new FMulticastDelegateProperty();
            NameToFieldClassMap[FMulticastInlineDelegateProperty.TYPE_NAME] = () => new FMulticastInlineDelegateProperty();
            NameToFieldClassMap[FMulticastSparseDelegateProperty.TYPE_NAME] = () => new FMulticastSparseDelegateProperty();
            NameToFieldClassMap[FNameProperty.TYPE_NAME] = () => new FNameProperty();
            NameToFieldClassMap[FNumericProperty.TYPE_NAME] = () => new FNumericProperty();
            NameToFieldClassMap[FObjectProperty.TYPE_NAME] = () => new FObjectProperty();
            NameToFieldClassMap[FObjectPropertyBase.TYPE_NAME] = () => new FObjectPropertyBase();
            NameToFieldClassMap[FObjectPtrProperty.TYPE_NAME] = () => new FObjectPtrProperty();
            NameToFieldClassMap[FProperty.TYPE_NAME] = () => new FProperty();
            NameToFieldClassMap[FSetProperty.TYPE_NAME] = () => new FSetProperty();
            NameToFieldClassMap[FSoftClassProperty.TYPE_NAME] = () => new FSoftClassProperty();
            NameToFieldClassMap[FSoftObjectProperty.TYPE_NAME] = () => new FSoftObjectProperty();
            NameToFieldClassMap[FSoftObjectProperty.OLD_TYPE_NAME] = () => new FSoftObjectProperty();
            NameToFieldClassMap[FStrProperty.TYPE_NAME] = () => new FStrProperty();
            NameToFieldClassMap[FStructProperty.TYPE_NAME] = () => new FStructProperty();
            NameToFieldClassMap[FTextProperty.TYPE_NAME] = () => new FTextProperty();
            NameToFieldClassMap[FUInt16Property.TYPE_NAME] = () => new FUInt16Property();
            NameToFieldClassMap[FUInt32Property.TYPE_NAME] = () => new FUInt32Property();
            NameToFieldClassMap[FUInt64Property.TYPE_NAME] = () => new FUInt64Property();
            NameToFieldClassMap[FWeakObjectProperty.TYPE_NAME] = () => new FWeakObjectProperty();
        }

        [Location("TMap<FName, FFieldClass*>& FFieldClass::GetNameToFieldClassMap()")]
        public static Dictionary<string, Func<FField>> GetNameToFieldClassMap()
        {
            return NameToFieldClassMap;
        }
    }
}
