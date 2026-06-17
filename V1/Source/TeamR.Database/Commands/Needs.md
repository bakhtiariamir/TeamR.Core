برای محصولی که تو داری می‌سازی، پیشنهاد من این است:

سطح اول
Permission
Role
RolePermission
UserRole
سطح دوم
PositionPermission
سطح سوم
DocumentPermission
KnowledgePermission

و AccessLevel فقط یک Enum Flags باشد، نه یک Entity مستقل. این ساختار هم در EF Core ساده‌تر است و هم در آینده برای Workflow و Approval دردسر ایجاد نمی‌کند.