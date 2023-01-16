using MySqlConnector;
using System.Data;
using System.Text.RegularExpressions;

namespace SalesInventoryApp
{
    public partial class SupplierPrompt : Form
    {
        public MySqlConnection connection { get; set; }
        private readonly Supplier supplierForm;

        public SupplierPrompt(string operation, Supplier supplierForm)
        {
            InitializeComponent();
            this.supplierForm = supplierForm;

            if (operation != "Delete")
            {
                if (operation == "Edit")
                {
                    Text = HeaderText.Text = "Edit Supplier";
                    BtnOne.Text = "Save";
                }

                MessagePanel.Visible = false;
            }
            else
            {
                Size = new Size(375, 153);
                InputPanel.Visible = false;
                Text = HeaderText.Text = "Delete Supplier";
                MessageText.Text += this.supplierForm.selectedRowSupplier + "?";
                MessagePanel.BringToFront();
                BtnOne.Text = "Yes";
                BtnTwo.Text = "No";
                BtnOne.BringToFront();
                BtnTwo.BringToFront();
            }

            Dashboard.ReduceFlicker(this);
        }

        private void BtnOne_Click(object sender, EventArgs e)
        {
            string supplierNameInput = Supplier.Text.Trim(),
                   addressInput = Address.Text.Trim(),
                   contactNumberInput = ContactNumber.Text.Trim(),
                   info = "Invalid",
                   message = "";

            Boolean supplierExist = false,
                    addressExist = false,
                    contactNumberExist = false,
                    allExist = false;

            DialogResult = DialogResult.None;
            connection.Open();

            using (MySqlCommand command = connection.CreateCommand())
            {
                if (BtnOne.Text != "Yes")
                {
                    if (!string.IsNullOrWhiteSpace(supplierNameInput) && !string.IsNullOrWhiteSpace(addressInput) && !string.IsNullOrWhiteSpace(contactNumberInput))
                    {
                        using (MySqlCommand getAllSuppliers = new("SELECT * FROM supplier", connection))
                        {
                            using MySqlDataReader dataReader = getAllSuppliers.ExecuteReader();

                            while (dataReader.Read())
                            {
                                if (dataReader[1].ToString() == supplierNameInput)
                                    supplierExist = true;

                                if (dataReader[2].ToString() == addressInput)
                                    addressExist = true;

                                if (dataReader[3].ToString() == contactNumberInput)
                                    contactNumberExist = true;

                                if (supplierExist && addressExist && contactNumberExist)
                                {
                                    allExist = true;
                                    break;
                                }
                            }
                        }

                        if (Regex.IsMatch(ContactNumber.Text.Trim(), "^[0-9]+$"))
                        {
                            if (allExist && BtnOne.Text == "Add" || allExist && supplierNameInput != supplierForm.selectedRowSupplier && addressInput != supplierForm.selectedRowAddress && contactNumberInput != supplierForm.selectedRowContactNumber)
                                message = "All info already exist";
                            else if (supplierExist && addressExist && BtnOne.Text == "Add" || supplierExist && addressExist && supplierNameInput != supplierForm.selectedRowSupplier && addressInput != supplierForm.selectedRowAddress)
                                message = "Supplier and address already exist.";
                            else if (addressExist && contactNumberExist && BtnOne.Text == "Add" || addressExist && contactNumberExist && addressInput != supplierForm.selectedRowAddress && contactNumberInput != supplierForm.selectedRowContactNumber)
                                message = "Address and contact number already exist.";
                            else if (contactNumberExist && supplierExist && BtnOne.Text == "Add" || contactNumberExist && supplierExist && contactNumberInput != supplierForm.selectedRowContactNumber && supplierNameInput != supplierForm.selectedRowSupplier)
                                message = "Supplier and contact number already exist.";
                            else if (supplierExist && BtnOne.Text == "Add" || supplierExist && supplierNameInput != supplierForm.selectedRowSupplier)
                                message = "Supplier already exist.";
                            else if (addressExist && BtnOne.Text == "Add" || addressExist && addressInput != supplierForm.selectedRowAddress)
                                message = "Address already exist.";
                            else if (contactNumberExist && BtnOne.Text == "Add" || contactNumberExist && contactNumberInput != supplierForm.selectedRowContactNumber)
                                message = "Contact number already exist.";
                            else
                            {
                                if (BtnOne.Text == "Add")
                                {
                                    command.CommandText = "INSERT INTO supplier(name, address, contact_number) VALUES(?, ?, ?)";
                                    message = "New supplier added successfully.";
                                }
                                else
                                {
                                    command.CommandText = "UPDATE supplier SET name = ?, address = ?, contact_number = ? WHERE id = ?";
                                    message = "Supplier " + supplierForm.selectedRowSupplier + " updated successfully.";
                                }

                                command.Parameters.Add("supplierName", (DbType)SqlDbType.VarChar).Value = Supplier.Text.Trim();
                                command.Parameters.Add("address", (DbType)SqlDbType.VarChar).Value = Address.Text.Trim();
                                command.Parameters.Add("contactNumber", (DbType)SqlDbType.VarChar).Value = ContactNumber.Text.Trim();

                                if (BtnOne.Text == "Save")
                                    command.Parameters.Add("id", (DbType)SqlDbType.Int).Value = supplierForm.selectedRowId;

                                info = "Success";
                                DialogResult = DialogResult.OK;
                            }
                        } 
                        else
                            message = "Please input a valid contact number.";
                    }
                    else
                    {
                        info = "Warning";
                        message = "Please fill out the required fields.";
                    }
                }
                else
                {
                    command.CommandText = "DELETE FROM supplier WHERE id = ?";
                    command.Parameters.Add("id", (DbType)SqlDbType.Int).Value = supplierForm.selectedRowId;
                    message = "Supplier " + supplierNameInput + " deleted successfully.";
                    info = "Success";
                    DialogResult = DialogResult.OK;
                }

                if (command.CommandText != "")
                {
                    command.Prepare();
                    command.ExecuteNonQuery();
                }
            }

            connection.Close();
            Dashboard.ShowMessage(this, supplierForm, info, message, DialogResult);
        }

        private void BtnTwo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
