// <auto-generated />
using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Scaffolding;

#pragma warning disable 219, 612, 618
#nullable disable

namespace TestNamespace
{
    internal partial class PrincipalDerivedEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelTestBase+PrincipalDerived<Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelTestBase+DependentBase<long?>>",
                typeof(CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<long?>>),
                baseEntityType,
                discriminatorProperty: "Discriminator",
                discriminatorValue: "PrincipalDerived<DependentBase<long?>>",
                propertyCount: 0,
                navigationCount: 1,
                foreignKeyCount: 1);

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("PrincipalId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("Id") }),
                principalEntityType,
                deleteBehavior: DeleteBehavior.Cascade,
                required: true);

            var deriveds = principalEntityType.AddNavigation("Deriveds",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<CompiledModelTestBase.PrincipalBase>),
                propertyInfo: typeof(CompiledModelTestBase.PrincipalBase).GetProperty("Deriveds", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CompiledModelTestBase.PrincipalBase).GetField("<Deriveds>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}