using System;
using Xunit;
using Xunit.Sdk;

namespace FluentAssertions.Specs.Primitives;

/// <content>
/// The [Not]BeLowerCased specs.
/// </content>
public partial class StringAssertionSpecs
{
    public class BeLowerCased
    {
        [Fact]
        public void When_a_lower_string_is_supposed_to_be_lower_it_should_succeed()
        {
            // Arrange
            string actual = "abc";

            // Act / Assert
            actual.Should().BeLowerCased();
        }

        [Fact]
        public void When_an_empty_string_is_supposed_to_be_lower_it_should_succeed()
        {
            // Arrange
            string actual = "";

            // Act / Assert
            actual.Should().BeLowerCased();
        }

        [Fact]
        public void When_a_non_lower_string_is_supposed_to_be_lower_it_should_fail()
        {
            // Arrange
            string actual = "ABC";

            // Act
            Action act = () => actual.Should().BeLowerCased();

            // Assert
            act.Should().Throw<XunitException>();
        }

        [Fact]
        public void When_a_lower_case_string_with_numbers_is_supposed_to_be_in_lower_case_only_it_should_succeed()
        {
            // Arrange
            string actual = "a123";

            // Act / Assert
            actual.Should().BeLowerCased();
        }

        [Fact]
        public void When_a_lower_case_string_with_special_characters_is_supposed_to_be_in_lower_case_only_it_should_succeed()
        {
            // Arrange
            string actual = "abc!@#$/";

            // Act / Assert
            actual.Should().BeLowerCased();
        }

        [Fact]
        public void When_a_non_lower_string_is_supposed_to_be_lower_it_should_fail_with_descriptive_message()
        {
            // Arrange
            string actual = "ABC";

            // Act
            Action act = () => actual.Should().BeLowerCased("because we want to test the failure {0}", "message");

            // Assert
            act.Should().Throw<XunitException>().WithMessage(
                "Expected all characters in actual to be lower cased because we want to test the failure message, but found \"ABC\".");
        }

        [Fact]
        public void When_checking_for_a_lower_string_and_it_is_null_it_should_throw()
        {
            // Arrange
            string nullString = null;

            // Act
            Action act = () => nullString.Should().BeLowerCased("because strings should never be {0}", "null");

            // Assert
            act.Should().Throw<XunitException>().WithMessage(
                "Expected all characters in nullString to be lower cased because strings should never be null, but found <null>.");
        }
    }

    public class NotBeLowerCased
    {
        [Fact]
        public void When_a_non_lower_string_is_supposed_to_be_upper_it_should_succeed()
        {
            // Arrange
            string actual = "ABC";

            // Act / Assert
            actual.Should().NotBeLowerCased();
        }

        [Fact]
        public void When_a_null_string_is_not_supposed_to_be_lower_it_should_succeed()
        {
            // Arrange
            string actual = null;

            // Act / Assert
            actual.Should().NotBeLowerCased();
        }

        [Fact]
        public void When_a_lower_string_is_supposed_to_be_upper_it_should_throw()
        {
            // Arrange
            string actual = "abc";

            // Act
            Action act = () => actual.Should().NotBeLowerCased();

            // Assert
            act.Should().Throw<XunitException>();
        }

        [Fact]
        public void When_a_lower_case_string_with_numbers_is_not_supposed_to_be_in_lower_case_only_it_should_succeed()
        {
            // Arrange
            string actual = "A1";

            // Act / Assert
            actual.Should().NotBeLowerCased();
        }

        [Fact]
        public void When_a_lower_string_is_not_supposed_to_be_lower_it_should_fail_with_descriptive_message()
        {
            // Arrange
            string actual = "abc";

            // Act
            Action act = () => actual.Should().NotBeLowerCased("because we want to test the failure {0}", "message");

            // Assert
            act.Should().Throw<XunitException>().WithMessage(
                "Did not expect any characters in actual to be lower cased because we want to test the failure message.");
        }
    }

    public class NotHaveAnyLowerCasing
    {
        [Fact]
        public void When_a_non_lower_string_is_supposed_to_be_upper_it_should_succeed()
        {
            // Arrange
            string actual = "ABC";

            // Act / Assert
            actual.Should().NotHaveAnyLowerCasing();
        }

        [Fact]
        public void When_a_null_string_is_not_supposed_to_be_lower_it_should_succeed()
        {
            // Arrange
            string actual = null;

            // Act / Assert
            actual.Should().NotHaveAnyLowerCasing();
        }

        [Fact]
        public void When_a_complete_lower_string_is_supposed_to_be_completely_upper_it_should_throw()
        {
            // Arrange
            string actual = "abc";

            // Act
            Action act = () => actual.Should().NotHaveAnyLowerCasing();

            // Assert
            act.Should().Throw<XunitException>();
        }

        [Fact]
        public void When_a_partly_lower_string_is_supposed_to_be_completely_upper_it_should_throw()
        {
            // Arrange
            string actual = "Abc";

            // Act
            Action act = () => actual.Should().NotHaveAnyLowerCasing();

            // Assert
            act.Should().Throw<XunitException>();
        }

        [Fact]
        public void When_a_lower_case_string_with_numbers_is_not_supposed_to_be_in_lower_case_only_it_should_succeed()
        {
            // Arrange
            string actual = "A1";

            // Act / Assert
            actual.Should().NotHaveAnyLowerCasing();
        }

        [Fact]
        public void When_a_lower_case_string_with_numbers_is_supposed_to_be_in_lower_case_only_it_should_throw()
        {
            // Arrange
            string actual = "a1";

            // Act
            Action act = () => actual.Should().NotHaveAnyLowerCasing();

            // Assert
            act.Should().Throw<XunitException>();
        }

        [Fact]
        public void When_a_complete_lower_string_is_not_supposed_to_be_lower_it_should_fail_with_descriptive_message()
        {
            // Arrange
            string actual = "abc";

            // Act
            Action act = () => actual.Should().NotHaveAnyLowerCasing("because we want to test the failure {0}", "message");

            // Assert
            act.Should().Throw<XunitException>().WithMessage(
                "Did not expect one or more character(s) in actual to be lower cased because we want to test the failure message.");
        }

        [Fact]
        public void When_a_partly_lower_string_is_not_supposed_to_be_lower_it_should_fail_with_descriptive_message()
        {
            // Arrange
            string actual = "Abc";

            // Act
            Action act = () => actual.Should().NotHaveAnyLowerCasing("because we want to test the failure {0}", "message");

            // Assert
            act.Should().Throw<XunitException>().WithMessage(
                "Did not expect one or more character(s) in actual to be lower cased because we want to test the failure message.");
        }
    }
}
